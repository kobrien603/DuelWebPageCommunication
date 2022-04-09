
function openWindow(id, url) {
	const params = `toolbar=no,status=no,menubar=no,titlebar=no,height=${screen.height - 250},width=${screen.width - 350}`;
	window.open(url, id, params);
}