var ds = document.getElementsByClassName("flag");
var de = document.getElementsByClassName("flagC");

for (var k = 0; k < ds.length; k++) {
  if (ds[k].innerHTML === "") {
    ds[k].parentNode.innerHTML = "N/A";
  }
}

for (var k = 0; k < de.length; k++) {
  if (de[k].innerHTML === "") {
    de[k].innerHTML = "N/A";
  }
}