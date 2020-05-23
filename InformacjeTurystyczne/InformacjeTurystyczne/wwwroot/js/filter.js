import Util from "./utility.js";

const Filter = function (name, propertyName, ...items) {
    this.name = name;
    this.propertyName = propertyName;
    this.activeItems = [...items];
    this.inactiveItems = []; //TODO: this casues filter items to change places
    this.selected = false;
    this.onDirty = () => { };
    this.expanded = false;
}

Filter.prototype.makeDirty = function () {
    this.onDirty();
}

Filter.prototype.renderFilterItems = function (content, checked, items) {
    for (let item of items) {
        let checkbox = Util.createElement("input");
        checkbox.type = "checkbox";
        checkbox.id = item;
        checkbox.name = item;
        checkbox.value = item;
        checkbox.checked = checked;
        checkbox.addEventListener("change", () => {
            if (checkbox.checked) {
                this.activeItems.push(checkbox.id);
                Util.remove(this.inactiveItems, checkbox.id);
            } else {
                this.inactiveItems.push(checkbox.id);
                Util.remove(this.activeItems, checkbox.id);
            }
            this.makeDirty();
        });
        content.appendChild(checkbox);
        let label = Util.createElement("label", { withText: item });
        label.htmlFor = item;
        content.appendChild(label);
        content.appendChild(Util.createElement("br"));
    }
}

Filter.prototype.render = function () {
    let filterDiv = Util.createElement("div", { withClass: "expand" });

    let button = Util.createElement("button", { withText: this.name, withClass: ["toggle-button", "expand__button"] });
    
    filterDiv.appendChild(button);

    let content = Util.createElement("div", { withClass: "expand__content" });
    this.renderFilterItems(content, true, this.activeItems);
    this.renderFilterItems(content, false, this.inactiveItems);
    filterDiv.appendChild(content);

    if (this.expanded) {
        button.classList.add("toggle-button--active");
        content.classList.add("show");
    }

    button.addEventListener("click", (e) => {
        this.expanded = !this.expanded;
        button.classList.toggle("toggle-button--active");
        content.classList.toggle("show");
    });

    return filterDiv;
}

Filter.prototype.check = function (item) {
    return this.activeItems.includes(item);
}

export default Filter;