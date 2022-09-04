
const validarForm = (p) => {
    let n = p.length - 1;
    let c = 0;
    for (let i = 0; i < n; i++) {
        if (p[i].value == "") c++;
    }
    if (c != 0) {
        alert("Ingrese todos los campos");
    } else {
        for (let i = 0; i < n; i++) {
            if (p[i].type != "button") {
                p[i].value = "";
            }

        }
    }
};

const form = document.getElementById("submitBtn");

form.addEventListener('click', e => {
    e.preventDefault();
    validarForm(e.target.parentElement.parentElement);
});
