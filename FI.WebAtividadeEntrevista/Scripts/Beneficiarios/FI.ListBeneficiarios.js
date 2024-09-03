
$(document).ready(function () {

    if (document.getElementById("gridBeneficiarios")) {
        $('#gridBeneficiarios').jtable({
            title: 'Beneficiarios',
            paging: true, //Enable paging
            pageSize: 5, //Set page size (default: 10)
            sorting: true, //Enable sorting
            defaultSorting: 'Nome ASC', //Set default sorting
            actions: {
                listAction: 'Beneficiario/BeneficiarioList/1' //urlBeneficiarioList,
            },
            fields: {
                Nome: {
                    title: 'Nome',
                    width: '50%'
                },
                CPF: {
                    title: 'CPF',
                    width: '35%'
                }
            }
        });
        alert("gridBeneficiariosOK2");
    }

    //Load student list from server
    if (document.getElementById("gridBeneficiarios"))
        $('#gridBeneficiarios').jtable('load');
})