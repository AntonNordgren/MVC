getAllPersons();

function getAllPersons() {
    $.get("/Ajax/GetPeople", null, function(data) {
        $("#PeopleList").html(data);
    })
}

function getPersonById() {
    let personIdValue = document.getElementById("idInputField").value;

    $.post("/Ajax/FindPersonById", { personId: personIdValue }, function (data) {
        $("#PeopleList").html(data);
    })
}

function deletePersonById() {
    let personIdValue = document.getElementById("idInputField").value;

    $.post("/Ajax/DeletePersonById", { personId: personIdValue }, function (data) {
    }).done(function () {
        document.getElementById("messageHeader").innerHTML = "Successfully Deleted Person.";
        getAllPersons();
    }).fail(function () {
        document.getElementById("messageHeader").innerHTML = "No Person with that Id.";
    })
}