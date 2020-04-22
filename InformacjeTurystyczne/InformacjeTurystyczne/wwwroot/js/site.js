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
}

const Filter = () => {
    const object = {};

    object.filterExpression = Map();
    object.setAllawedValue = function (property, value) {
        if (this.filterExpression.has(property)) {
            this.filterExpression.set(property, Set());
        }
        this.filterExpression.get(property).add(value);
    }
    object.removeAllowedValue = function (property, value) {
        this.filterExpression.get(property).delete(value);
    }
    object.filter = function (item) {
        this.filterExpression.forEach((key, value) => {
            if (value.has(item.records [key]) || value.has("any")) {
                return true;
            }
            return false;
        })
        return true;
    }
    return object;
}

const TouristInfoPage = (data) => {
    const { items = null, regions = null, types = null } = data;

    const object = {};
    object.items = items;
    object.regions = regions;
    object.types = types;
    object.filter = Filter();
    object.renderFiltered = function () {
        TouristInfoPage.renderItems(this.items.map())
    }

    return object;
}

TouristInfoPage.renderItems = function (items) {
    let fragment = document.createDocumentFragment();
    for (let infoItem of items) {
        let info__item = document.createElement("div");
        info__item.classList.add("info__item");

        info__item.appendChild(createElement("h1", { withText: infoItem.name }));
        for (let key of infoItem.records) {
            info__item.appendChild(createElement("p", { withText: key.tag }));
            info__item.appendChild(createElement("p", { withText: key.value }));
        }
        fragment.appendChild(info__item);
    }
    document.getElementById("info__list").appendChild(fragment);
}