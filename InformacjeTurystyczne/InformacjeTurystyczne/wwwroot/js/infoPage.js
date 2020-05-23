import Filter from "./filter.js";

const InfoPage = function (items, regions, types) {
    this.regions = regions;
    this.items = items;
    this.types = types;
    this.typeFilter = new Filter("Typ", "type", ...types);
    this.regionFilter = new Filter("Region", "region", ...regions);
};

InfoPage.prototype.renderItems = function () {
    let fragment = document.createDocumentFragment();
    for (let item of this.items) {
        fragment.appendChild(item.render());
    }
    document.getElementById("info__list").appendChild(fragment);
};

InfoPage.prototype.renderFilters = function () {
    document.getElementsByClassName("sidebar")[0].prepend(this.regionFilter.render());
    document.getElementsByClassName("sidebar")[0].prepend(this.typeFilter.render());
}

export default InfoPage;