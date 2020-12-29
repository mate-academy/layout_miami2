const nav = document.querySelector(".nav");

nav.onclick = (event) => {
  if (event.target.tagName === 'A') {
    nav.querySelector('.active-link').setAttribute('class', 'nav__link link');
    event.target.setAttribute('class','active-link nav__link');
  }
};



