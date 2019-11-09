// Jquery Mask
$(document).ready(function () {
    $('.placa').mask('SSS-0000', { clearIfNotMatch: true });
    $('.renavam').mask('00000000000', { clearIfNotMatch: true })
    $('.float_number').mask('#.##0,00', { reverse: true });
});