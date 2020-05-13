
const Utility = {};

Utility.createElement = function (tag, options)
{
    const { withText, withClass } = options;

    let element = document.createElement(tag);
    if (withText) {
        let text = document.createTextNode(withText);
        element.appendChild(text);
    }
    if (withClass) {
        element.classList.add(withClass);
    }
    return element;
}

Utility.createRow = function (...texts) {
    let rowDiv = Utility.createElement("div", { withClass: "row" });
    for (let text of texts) {
        rowDiv.appendChild(Utility.createElement("p", { withText: text }));
    }
    return rowDiv;
}

export default Utility;