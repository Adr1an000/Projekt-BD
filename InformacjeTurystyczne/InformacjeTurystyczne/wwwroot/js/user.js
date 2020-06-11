import Util from "./utility.js";

const User = function (name) {
    this.name = name;
    this.regionPermissions = {};
    this.permissionsExpanded = false;
}

User.prototype.renderCheckbox = function (content, checked, id, name) {
    let checkbox = Util.createElement("input");
    checkbox.type = "checkbox";
    checkbox.id = id;
    checkbox.name = name;
    checkbox.value = name;
    checkbox.checked = checked;
    checkbox.addEventListener("change", () => {
        this.items[checkbox.id] = !this.items[checkbox.id];
        this.makeDirty();
    });
    content.appendChild(checkbox);
    let label = Util.createElement("label", { withText: name });
    label.htmlFor = id;
    content.appendChild(label);
    content.appendChild(Util.createElement("br"));
}

User.prototype.render = function () {
    let itemDiv = Util.createElement("div", { withClass: "info__item" });

    itemDiv.appendChild(Util.createElement("h1", { withText: this.name }));
    let deleteButton = Util.createElement("button", { withText: "Usuń", withClass: ["info__delete"] });
    itemDiv.appendChild(deleteButton);
    let button = Util.createElement("button", { withText: "Edytuj uprawnienia", withClass: ["toggle-button", "expand__button"] });

    itemDiv.appendChild(button);

    let content = Util.createElement("div", { withClass: "expand__content" });
    for (let [key, val] of Object.entries(this.regionPermissions)) {
        this.renderCheckbox(content, val, `${this.name}_${key}`, key);
    }
    itemDiv.appendChild(content);

    if (this.permissionsExpanded) {
        button.classList.add("toggle-button--active");
        content.classList.add("show");
    }

    button.addEventListener("click", (e) => {
        this.permissionsExpanded = !this.permissionsExpanded;
        button.classList.toggle("toggle-button--active");
        content.classList.toggle("show");
    });

    return itemDiv;
}

export default User;