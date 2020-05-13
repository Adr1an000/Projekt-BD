
const Utility = {};

Utility.createElement(tag, options)
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

export default Utility;