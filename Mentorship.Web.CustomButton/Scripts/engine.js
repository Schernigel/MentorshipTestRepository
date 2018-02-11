function showName(obj) {
    document.getElementById('info').style.display = 'block';
    var text = obj.childNodes[0].textContent;
    var size = obj.attributes.size.value;
    var theme = obj.attributes.theme.value;

    if (text == 'Disabled') {
        document.getElementById('info').innerHTML = 'This button can not be pressed';
    } else {
        document.getElementById('info').innerHTML = 'Was pressed the ' + theme + ' ' + size + ' ' + text + ' button';
    }
    setTimeout(function () {
        document.getElementById('info').style.display = 'none';
    }, 3000);
}