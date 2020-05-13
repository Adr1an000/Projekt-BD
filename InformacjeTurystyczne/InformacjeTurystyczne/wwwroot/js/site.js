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

const InfoPage = function (items, regions, types) {
    this.regions = regions;
    this.items = items;
    this.types = types;
};

InfoPage.prototype.renderItems = function () {
    let fragment = document.createDocumentFragment();
    for (let item of this.items) {
        fragment.appendChild(item.render());
    }
    document.getElementById("info__list").appendChild(fragment);
};