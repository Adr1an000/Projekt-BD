using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;
using InformacjeTurystyczne.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace InformacjeTurystyczne.Controllers.TabelsController
{
    public class RegionController : Controller
    {
        private readonly IRegionRepository _regionRepository;

        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public async Task<IActionResult> Index(int? id, int? IdEntertainment)
        {
            var regions = _regionRepository.GetAllRegion();

            return View(await regions);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regions = await _regionRepository.GetRegionByID(id);
            if (regions == null)
            {
                return NotFound();
            }

            return View(regions);
        }

        public IActionResult Create()
        {
            var region = new Region();
            region.RegionLocation = new List<RegionLocation>();

            PopulateRegion(region);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRegion,Name")] Region region, string[] selectedTrials)
        {
            if (selectedTrials != null)
            {
                region.RegionLocation = new List<RegionLocation>();
                foreach(var trial in selectedTrials)
                {
                    var trialToAdd = new RegionLocation { IdRegion = region.IdRegion, IdTrial = int.Parse(trial) };
                    region.RegionLocation.Add(trialToAdd);
                }
            }

            if (ModelState.IsValid)
            {
                await _regionRepository.AddRegionAsync(region);

                return RedirectToAction(nameof(Index));
            }

            PopulateRegion(region);

            return View(region);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var region = await _regionRepository.GetRegionByID(id);

            if (region == null)
            {
                return NotFound();
            }

            PopulateRegion(region);

            return View(region);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id, string[] selectedTrials)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regionToUpdate = await _regionRepository.GetRegionByID(id);

            if (await TryUpdateModelAsync<Region>(regionToUpdate,
                    "",
                    c => c.Name))
            {
                UpdateRegion(selectedTrials, regionToUpdate);

                try
                {
                    await _regionRepository.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(String.Empty, "Nie można zapisać zmian.");
                }

                return RedirectToAction(nameof(Index));
            }

            UpdateRegion(selectedTrials, regionToUpdate);

            return View(regionToUpdate);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var region = await _regionRepository.GetRegionByID(id);

            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        private void PopulateRegion(Region regionToUpdate)
        {
            var allTrials = _regionRepository.GetAllTrials();

            var regionTrial = new HashSet<int?>(regionToUpdate.RegionLocation.Select(c => c.IdTrial));

            var viewModelTrial = new List<PermissionTrialData>();

            foreach(var trial in allTrials)
            {
                viewModelTrial.Add(new PermissionTrialData
                {
                    IdTrial = trial.IdTrial,
                    Name = trial.Name,
                    Assigned = regionTrial.Contains(trial.IdTrial)
                });
            }

            ViewData["Trials"] = viewModelTrial;
        }

        private void UpdateRegion(string[] selectedTrials, Region regionToUpdate)
        {
            if(selectedTrials == null)
            {
                regionToUpdate.RegionLocation = new List<RegionLocation>();

                return;
            }

            var selectedTrialsHS = new HashSet<string>(selectedTrials);
            var regionTrials = new HashSet<int>
                (regionToUpdate.RegionLocation.Select(c => c.Trial.IdTrial));

            foreach(var trial in _regionRepository.GetAllTrials())
            {
                if(selectedTrialsHS.Contains(trial.IdTrial.ToString()))
                {
                    if(!regionTrials.Contains(trial.IdTrial))
                    {
                        regionToUpdate.RegionLocation.Add(new RegionLocation { IdRegion = regionToUpdate.IdRegion, IdTrial = trial.IdTrial });
                    }
                }
                else
                {
                    if(regionTrials.Contains(trial.IdTrial))
                    {
                        RegionLocation trialToRemove = regionToUpdate.RegionLocation.FirstOrDefault(i => i.IdTrial == trial.IdTrial);
                        _regionRepository.RemoveTrial(trialToRemove);
                    }
                }
            }
        }

        // TODO!!! dodać kasowanie odpowiednio zawartości tabeli RegionLocation po usunieciu regionu!

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var region = await _regionRepository.GetRegionByIDWithoutIncludeAndAsNoTracking(id);
            await _regionRepository.DeleteRegionAsync(region);

            return RedirectToAction(nameof(Index));
        }
    }
}