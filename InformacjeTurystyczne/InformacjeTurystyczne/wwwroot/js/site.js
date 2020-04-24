// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/* Navigation bar highlighting*/
const initNavbar = (controller, action) => {
    console.log(controller);
    console.log(action);
    let elem;
    if (controller === "Home")
        elem = document.querySelector(`a.navbar__link[href='/']`);
    else if (action === "Index")
        elem = document.querySelector(`a.navbar__link[href='/${controller}']`);
    else
        elem = document.querySelector(`a.navbar__link[href='/${controller}/${action}']`);
    elem.classList.add("navbar__link--active");
};

const initHomepage = () => {
    const resizeHomepage = () => {
        var home = document.getElementById("homepage");
        home.style.height = (document.documentElement.clientHeight - home.offsetTop) + "px";
    }
    window.addEventListener("load", resizeHomepage);
    window.addEventListener("resize", resizeHomepage);
}

const initToggleButtons = () => {
    let buttons = document.getElementsByClassName("toggle-button");
    for (let i = 0; i < buttons.length; i++) {
        buttons[i].addEventListener("click", toggleButton);
    }
};

const toggleButton = function (e) {
    this.classList.toggle("toggle-button--active");
    document.getElementById(this.getAttribute("data-show")).classList.toggle("show");
};

const createElement = (tag, options) => {
    const { withText = null } = options;

    let element = document.createElement(tag);
    if (withText) {
        let text = document.createTextNode(withText);
        element.appendChild(text);
    }
    return element;
};

const Filter = function () {

};
Filter.prototype.addProperty = function (name) {
    if (typeof this[name] === "undefined") {
        this[name] = {};
        this[name].selected = new Set();
        this[name].deselected = new Set();
    }
};
Filter.prototype.select = function (name, ...values) {
    this.addProperty(name);

    values.forEach((value) => {
        this[name].selected.add(value);
        this[name].deselected.delete(value);
    });
};
Filter.prototype.deselect = function (name, ...values) {
    this.addProperty(name);

    values.forEach((value) => {
        this[name].deselected.add(value);
        this[name].selected.delete(value);
    });
};
Filter.prototype.check = function (item) {
    for (let property in this) {
        if (!this.hasOwnProperty(property)) {
            continue;
        }
        if (typeof item[property] === "undefined" || !this[property].selected.has(item[property].value)) {
            return false;
        }
    }
    return true;
};
const InfoItem = function () {

};
InfoItem.prototype.addProperty = function (name, value, displayName, displayValue){
    this[name] = {};
    this[name].value = value;
    this[name].displayName = displayName;
    this[name].displayValue = displayValue;
};

const InfoPage = function (items, regions, types) {
    this.regions = regions;
    this.items = items;
    this.types = types;
    this.filter = new Filter();
};

InfoPage.prototype.renderItems = function () {
    InfoPage.renderItems(this.items.filter((item) => this.filter.check(item)));
};

InfoPage.renderItems = function (items) {
    let fragment = document.createDocumentFragment();
    for (let infoItem of items) {
        let info__item = document.createElement("div");
        info__item.classList.add("info__item");

        info__item.appendChild(createElement("h1", { withText: infoItem.name.displayValue }));
        for (let key in infoItem) {
            if (infoItem.hasOwnProperty(key) && key !== "name") {
                info__item.appendChild(createElement("p", { withText: infoItem[key].displayName }));
                info__item.appendChild(createElement("p", { withText: infoItem[key].displayValue }));
            }
        }
        fragment.appendChild(info__item);
    }
    document.getElementById("info__list").appendChild(fragment);
};