// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#deleteStudentConfirmModal').on('show.bs.modal', function (event) {
    var button = $(event.relatedTarget);
    var adminNo = button.data('adminno');
    var modal = $(this);
    modal.find('.modal-dialog form').attr('action', 'Home/Delete/' + adminNo);
});