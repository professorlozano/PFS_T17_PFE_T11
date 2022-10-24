function cadastrarNewsletter(){
    let email = document.getElementById("campo-email").value
    alert(email)
}

function mostrarMenu($event){
    let menu = document.getElementById("menu")

    //if(menu.style.display == "none")
    if(getComputedStyle(menu).display == "none"){
        menu.style.display = "flex"
    }
    else{
        menu.style.display = "none"
    }

    event.preventDefault();
}