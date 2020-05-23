import Util from "./utility.js";

const Filter = function (name, propertyName, ...items) {
    this.name = name;
    this.propertyName = propertyName;
    this.activeItems = [...items];
    this.inactiveItems = [];
    this.selected = false;
}

Filter.prototype.render = function () {
    let filterDiv = Util.createElement("div", { withClass: "expand" });

    let button = Util.createElement("button", { withText: this.name, withClass: ["toggle-button", "expand__button"] });
    filterDiv.appendChild(button);

    let content = Util.createElement("div", { withClass: "expand__content" });
    for (let item of this.activeItems) {
        let checkbox = Util.createElement("input");
        checkbox.type = "checkbox";
        checkbox.id = item;
        checkbox.name = item;
        checkbox.value = item;
        content.appendChild(checkbox);
        let label = Util.createElement("label", { withText: item });
        label.htmlFor = item;
        content.appendChild(label);
        content.appendChild(Util.createElement("br"));
    }
    filterDiv.appendChild(content);

    button.addEventListener("click", function (e) {
        button.classList.toggle("toggle-button--active");
        content.classList.toggle("show");
    });

    return filterDiv;
}

export default Filter;