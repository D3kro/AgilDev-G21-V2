const number = document.getElementById("cantidad");
const repuestos = document.getElementById("repuesto");
const tableRepuestos = document.getElementById('tableRepuestos');

const deleteRow = e => {
    tableRepuestos.deleteRow(e.target.parentElement.parentElement.rowIndex);
};

document.getElementById('addBtn').addEventListener('click', e => {

    const tbody =  tableRepuestos.children[1]; 
    const tr = document.createElement('tr');
    let td = document.createElement('td');
    td.innerText = number.value;
    tr.appendChild(td);
    td = document.createElement('td');
    td.innerText = repuestos.value;
    tr.appendChild(td);
    
    const btnDelete = document.createElement('input');
    btnDelete.setAttribute('type', 'button');
    btnDelete.setAttribute('value', 'Eliminar');

    btnDelete.addEventListener('click', deleteRow);

    td = document.createElement('td');
    td.appendChild(btnDelete);
    tr.appendChild(td);    
    
    tbody.appendChild(tr);
});


/* 
document.getElementById('addBtn').addEventListener('click', e => {
    const textRepuestos = document.getElementById('textRepuestos');
    let des = number.value + " - " + repuestos.value + ';\n';
    textRepuestos.value += des;
});
*/