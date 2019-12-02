$document.ready(function () {
	$.ajax({
		url: '@Url.Action("ChoresTable", "Chores")',
		success: function (result) {
			$('#tableDiv').html(result);
		}
	});
});