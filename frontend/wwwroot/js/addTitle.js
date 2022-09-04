const select = document.getElementById('selectTypeUser');
select.addEventListener('change', e => {
    if(e.target.value == "Tecnico") {
        document.getElementById('tecTitle').setAttribute('value', '');
        document.getElementById('tecDiv').classList = "divInput";
    } else {
        document.getElementById('tecDiv').classList = "divInput hidden";
        document.getElementById('tecTitle').value = "texto temporal";
    }
});