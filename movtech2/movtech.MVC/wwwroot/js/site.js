// Jquery Mask
$(document).ready(function () {

    var SPMaskBehavior = function (val) {
        return val.replace(/\D/g, '').length === 11 ? '(00) 00000-0000' : '(00) 0000-00009';
    },
        spOptions = {
            onKeyPress: function (val, e, field, options) {
                field.mask(SPMaskBehavior.apply({}, arguments), options);
            }
        };


    var cpfOptions = {

        onComplete: function (val, e, f, invalid, options) {
            if (!ValidarCPF(val)) {                
                WarningAlert("CPF inválido", "");
                f.val('');
            }
        },
        reverse: true,
        clearIfNotMatch: true

    };

    var dateOptions = {       

        onComplete: function (val, e, f, invalid, options) {
            if (!validarData(val)) {
                WarningAlert("Data inválida!", "");
                f.val('');
            }
        },
        clearIfNotMatch: true
    }

    $('.phone').mask(SPMaskBehavior, spOptions);
    $('.cpf').mask('000.000.000-00', cpfOptions);
    $('.cnh_categoria').mask('SSSSS');
    $('.houseNumber').mask('00000');
    $('.date').mask('00/00/0000', dateOptions);
    $('.placa').mask('SSS-0000', { clearIfNotMatch: true });
    $('.renavam').mask('00000000000', { clearIfNotMatch: true })
    $('.cnh').mask('00000000000', { clearIfNotMatch: true })
    $('.cep').mask('00000-000', { clearIfNotMatch: true })
    $('.float_number').mask('#.##0,00', { reverse: true });
    $('.kms').mask('#.##0,0');

});

function ValidarCPF(strCPF) {
    strCPF = strCPF.replace(".", "").replace(".", "").replace("-", "");

    var Soma;
    var Resto;
    Soma = 0;
    if (strCPF == "00000000000") return false;
    if (strCPF == "11111111111") return false;
    if (strCPF == "22222222222") return false;
    if (strCPF == "33333333333") return false;
    if (strCPF == "44444444444") return false;
    if (strCPF == "55555555555") return false;
    if (strCPF == "66666666666") return false;
    if (strCPF == "77777777777") return false;
    if (strCPF == "88888888888") return false;
    if (strCPF == "99999999999") return false;

    for (i = 1; i <= 9; i++) Soma = Soma + parseInt(strCPF.substring(i - 1, i)) * (11 - i);
    Resto = (Soma * 10) % 11;

    if ((Resto == 10) || (Resto == 11)) Resto = 0;
    if (Resto != parseInt(strCPF.substring(9, 10))) return false;

    Soma = 0;
    for (i = 1; i <= 10; i++) Soma = Soma + parseInt(strCPF.substring(i - 1, i)) * (12 - i);
    Resto = (Soma * 10) % 11;

    if ((Resto == 10) || (Resto == 11)) Resto = 0;
    if (Resto != parseInt(strCPF.substring(10, 11))) return false;
    return true;


}

function validarData(dateString) {
    var data = dateString;
    var dia = data.substring(0, 2)
    var mes = data.substring(3, 5)
    var ano = data.substring(6, 10)

    //Criando um objeto Date usando os valores ano, mes e dia.
    var novaData = new Date(ano, (mes - 1), dia);

    var mesmoDia = parseInt(dia, 10) == parseInt(novaData.getDate());
    var mesmoMes = parseInt(mes, 10) == parseInt(novaData.getMonth()) + 1;
    var mesmoAno = parseInt(ano) == parseInt(novaData.getFullYear());

    if (!((mesmoDia) && (mesmoMes) && (mesmoAno))) {        
        return false;
    }
    return true;
}


function WarningAlert(title, text) {
    Swal.fire({
        title: title,
        html: text,
        icon: 'warning',
        confirmButtonText: 'Ok'
    })
}