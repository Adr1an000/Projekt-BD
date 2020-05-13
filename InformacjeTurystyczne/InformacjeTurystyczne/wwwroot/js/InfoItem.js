import Util from "./utility.js"

const InfoItem = function () {
}

InfoItem.prototype.addProperty = function (property, name, value) {
    if (this[property] === undefined) {
        this[property] = { name: name, value: value };
    } else {
        if (Array.isArray(this[property])) {
            this[property].push({ name: name, value: value });
        } else {
            this[property] = [this.property, { name: name, value: value }];
        }
    }
}

InfoItem.prototype.render = function () {
    const nameProperty = "name";
    let itemDiv = Util.createElement("div", { withClass: "info__item" });

    itemDiv.appendChild(Util.createElement("h1", { withText: this[nameProperty].value }));
    for (let key in this) {
        if (infoItem.hasOwnProperty(key) && key !== nameProperty) {
            let rowDiv = Util.createElement("div", { withClass: "row" });
            rowDiv.appendChild(createElement("p", { withText: this[key].name }));
            rowDiv.appendChild(createElement("p", { withText: this[key].value }));
            itemDiv.appendChild(rowDiv);
        }
    }
    return itemDiv;
}