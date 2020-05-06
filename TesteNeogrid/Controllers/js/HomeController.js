function RetornaJuros() {

    $.ajax({
        url: 'api/taxajuros',
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
        url: 'api/calculajuros?ValorInicial=' + document.getElementById("valorInicial").value + '&juros=' + jurosAPI + '&Meses=' + document.getElementById("valorTempo").value,
        type: "GET",
        success: function (data, textStatus, jqXHR) {
            alert(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert('Error occurred!');
        }

    });
}