$('#btnCalc').click(function () {
    let aGrade = ($('#aGrade').val()) * 50;
    let gpGrade = $('#gpGrade').val() * 10;
    let qGrade = $('#qGrade').val() * 10;
    let meGrade = $('#meGrade').val() * 10;
    let feGrade = $('#feGrade').val() * 10;
    let iGrade = $('#iGrade').val() * 10;

    let finalPer = (parseFloat(aGrade) + parseFloat(gpGrade) + parseFloat(qGrade) + parseFloat(meGrade) + parseFloat(feGrade) + parseFloat(iGrade)) / 100;
    let sfinalLetter = '';

    if (finalPer >= 94) {
        sfinalLetter = 'A'
    } else if (finalPer >= 90) {
        sfinalLetter = 'A-'
    } else if (finalPer >= 87) {
        sfinalLetter = 'B+'
    } else if (finalPer >= 84) {
        sfinalLetter = 'B'
    } else if (finalPer >= 80) {
        sfinalLetter = 'B-'
    } else if (finalPer >= 77) {
        sfinalLetter = 'C+'
    } else if (finalPer >= 74) {
        sfinalLetter = 'C'
    } else if (finalPer >= 70) {
        sfinalLetter = 'C-'
    } else if (finalPer >= 67) {
        sfinalLetter = 'D+'
    } else if (finalPer >= 64) {
        sfinalLetter = 'D'
    } else if (finalPer >= 60) {
        sfinalLetter = 'D-'
    } else {
        sfinalLetter = 'E'
    }

    $('#printPer').text(finalPer)
    $('#printLetter').text(sfinalLetter)

});