const user = document.getElementById('IdUser');
const pass = document.getElementById('passUser');
const submit = document.querySelector('.btnSubmit');
submit.addEventListener('click', e => {
    e.preventDefault();
    let c = 0;
    if(user.value == "") {
        alert('ingrese un nombre de usuario');
        c++;
    } 
    if(pass.value == "") {
         alert('ingrese una contraseña de usuario');
         c++;
    }

    if(c == 0) {
        window.location.replace('/views/RegistrarRevisiones');
    }
    
});
