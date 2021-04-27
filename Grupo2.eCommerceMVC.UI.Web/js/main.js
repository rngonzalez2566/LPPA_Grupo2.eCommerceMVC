var usuario = document.getElementById("usuario").innerHTML;

if (usuario != "") {
    document.getElementById("usuario").style.display = "flex";
    document.getElementById("panel").style.display = "flex";
    document.getElementById("logout").style.display = "flex";
    document.getElementById("login").style.display = "none";
    document.getElementById("registro").style.display = "none";
}