$document.ready(function () {
	$.ajax({
		url: '/Chores/ChoresTable',
		success: function (result) {
			$('#tableDiv').html(result);
		}
	});
});