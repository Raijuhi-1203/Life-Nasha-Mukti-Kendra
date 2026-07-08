
function ShowMessage(message, messagetype) {
    var cssclass;
    switch (messagetype) {
        case 'Success':
            cssclass = 'alert-success'
            break;
        case 'Error':
            cssclass = 'alert-danger'
            break;
        case 'Warning':
            cssclass = 'alert-warning'
            break;
        default:
            cssclass = 'alert-info'
    }
    $('#alert_container').append('<div id="alert_div" class="alert alert-dismissible ' + cssclass + '"><button class="close" data-dismiss="alert" aria-label="close">&times;</button><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
}