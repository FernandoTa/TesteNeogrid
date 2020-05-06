function RetornaJuros() {

    $.ajax({
        url: 'http://localhost:8080/Service.svc',
        type: "GET",
        success: function (data, textStatus, jqXHR) {
            alert(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert('Error occurred!');
        }

    });
}

function RetornaValorFinal() {
    var jurosAPI = 0;

    RetornaJuros();

    jurosAPI = data;
    $.ajax({
        url: 'http://localhost:8090/calculajuros?ValorInicial=' + document.getElementById("valorInicial").value + '&Meses=' + document.getElementById("valorTempo").value,
        type: "GET",
        success: function (data, textStatus, jqXHR) {
            alert(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert('Error occurred!');
        }

    });
}