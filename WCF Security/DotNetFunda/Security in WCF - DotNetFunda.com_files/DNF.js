function ShowMenuCatHome() {
    $("#divMenu").slideToggle();
}
function ShowMenuCatHomeD() {
    $("#divMenu").slideDown();
}
function ShowMenuCatHomeU() {
    $("#divMenu").slideUp();
}
function ShowHide(id) {
    $('#'+id).slideToggle();
}
function FormatText(tag, formatElement) {
    var el = document.getElementById(formatElement)
    var tagstart = '[' + tag + ']', tagend = '[/' + tag + '] '
    if (el.setSelectionRange) {
        if (el.selectionStart != el.selectionEnd)
            el.value = el.value.substring(0, el.selectionStart) + tagstart + el.value.substring(el.selectionStart, el.selectionEnd) + tagend + el.value.substring(el.selectionEnd, el.value.length)
        else {
            alert('Please select text to format.')
            return
        }
    }
    else {
        var selectedText = document.selection.createRange().text
        if (selectedText != "") {
            var newText = tagstart + selectedText + tagend
            document.selection.createRange().text = newText
        }
        else {
            alert('Please select text to format.')
            return
        }
    }
    WritePreview();
}

function IsEnterK(e) { var code; if (window.event) { code = window.event.keyCode; } else { code = e.which; } if (code == 13) { DoArticleSearch(); if (window.event) { window.event.keyCode = 0; } else { e.which = 0; } return false; } else { return true; } }
function ChangeClass(href, obj, clas) {
    obj.className == clas ? obj.className = '' : obj.className = clas;
    if (obj.className == 'highlight') document.getElementById(href).innerHTML = 'Hide Correct Answer';
    else document.getElementById(href).innerHTML = 'Show Correct Answer';
}

// get the confirmation only if page validator returns true
function ConfirmMeFirst()
{ if (Page_ClientValidate()) return confirm('Do you really want to proceed?'); return false; }

function PrintIt() {
    $("#header").toggle(); // hide the header
    $(".leftPanel").toggle(); // hide the lft panel
    $("#allPOM").trigger('click'); // hide the popright menu
    window.print(); // print it
}
function GoTop() {
    $('html, body').animate({ scrollTop: 0 }, 'fast');
}
function openWindowAGV(id) {
    urll = document.getElementById(id).value
    if (urll.length <= 0) {
        alert('Please specify url to open.')
        return false
    }
    newwindow = window.open(urll, 'durl')
    newwindow.focus()
}
$(function () {
    $(".table .tr:odd").addClass("trA");
    $(".sectionItem:odd").addClass("sectionItemA");
});