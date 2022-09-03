const user = document.getElementById('IdUser');
const pass = document.getElementById('passUser');
const submit = document.querySelector('.btnSubmit');
submit.addEventListener('click', e => {
    e.preventDefault();
    if(user.value == "") {
        e.preventDefault();
        alert('ingrese un nombre de usuario');
    } 
    if(pass.value == "") {
        e.preventDefault();
         alert('ingrese una contraseña de usuario');
    }
    window.location.replace('/nav/_navPageTec');
});
