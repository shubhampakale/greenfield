//Event handler logic 
function onSetData() {
    if (typeof (Storage) !== "undifined") {

        var txtemail = document.getElementById("txtemail");
        var email = txtemail.value;
        localStorage.setItem("useremail", email);
    }
    else {
        // No storage 
    }
}
function onGetData() {
    if (typeof (Storage) !== "undifined") {
        var lblResult = document.getElementById("lblresult");
        var result = localStorage.getItem("useremail")
        lblResult.innerHTML= result;
    }
    else {

    }
}

function onSetObj() {
    
    var fname = document.getElementById("txtfirstname").value;
    var lname = document.getElementById("txtlastname").value;
    var age = document.getElementById("txtage").value;
    

    var user = { 'fname': fname, 'lname': lname, 'age':age };
    sessionStorage.setItem('user', JSON.stringify(user));

    


    // json object storing 
}
function onGetObj() {

     
    var obj = JSON.parse(sessionStorage.user);


    lblresultfname.innerHTML = obj.fname;
    lblresultlname.innerHTML = obj.lname;
    lblresultage.innerHTML = obj.age;


}