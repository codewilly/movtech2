//Loading

function Loading(show) {
    if (show == true) {
        $("#loading").css({ display: 'block' });
    } else {
        $("#loading").css({ display: 'none' });
    }
}

//$(document).on("submit", "form", function () {
//    Loading(true);
//});


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

    var cnpjOptions = {

        onComplete: function (val, e, f, invalid, options) {
            if (!ValidarCNPJ(val)) {
                WarningAlert("CNPJ inválido", "");
                f.val('');
            }
        },
        reverse: true,
        clearIfNotMatch: true

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
    $('.cnpj').mask('00.000.000/0000-00', cnpjOptions);
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

function ValidarCNPJ(cnpj) {
    cnpj = cnpj.replace(/[^\d]+/g, '');

    if (cnpj == '') return false;

    if (cnpj.length != 14)
        return false;

    // Elimina CNPJs invalidos conhecidos
    if (cnpj == "00000000000000" ||
        cnpj == "11111111111111" ||
        cnpj == "22222222222222" ||
        cnpj == "33333333333333" ||
        cnpj == "44444444444444" ||
        cnpj == "55555555555555" ||
        cnpj == "66666666666666" ||
        cnpj == "77777777777777" ||
        cnpj == "88888888888888" ||
        cnpj == "99999999999999")
        return false;

    // Valida DVs
    tamanho = cnpj.length - 2
    numeros = cnpj.substring(0, tamanho);
    digitos = cnpj.substring(tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(0))
        return false;

    tamanho = tamanho + 1;
    numeros = cnpj.substring(0, tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(1))
        return false;

    return true;
}