import Filter from "./filter.js";

const InfoPage = function (items, regions) {
    this.regions = regions;
    this.items = items;
    this.regionFilter = new Filter("Region", "region", ...regions);

    this.regionFilter.onDirty = () => {
        this.renderFilters();
        this.renderItems();
    };
};

InfoPage.prototype.renderItems = function () {
    let fragment = document.createDocumentFragment();
    let list = document.getElementById("info__list");
    list.textContent = '';
    for (let item of this.items.filter(item => this.regionFilter.check(item.region))) {
        fragment.appendChild(item.render());
    }
    list.appendChild(fragment);
};

InfoPage.prototype.renderFilters = function () {
    let sidebar = document.getElementsByClassName("sidebar")[0];
    for (let child of sidebar.querySelectorAll(".expand")) {
        sidebar.removeChild(child);
    }

    sidebar.prepend(this.regionFilter.render());
}

export default InfoPage;