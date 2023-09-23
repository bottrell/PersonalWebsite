// Code to set an active class on the nav items on click
let navItems = document.querySelectorAll('.nav-item')

console.log(window.location.href);

if (window.location.href.includes("blog") || window.location.href.includes("posts")) {
    document.querySelector('#blog-link').classList.add('active');
}

else if (window.location.href.includes("experience")) {
    document.querySelector('#experience-link').classList.add('active');
}

else {
    document.querySelector('#about-me-link').classList.add('active');
}

// Code to remove the subtitle when on a post page
if (window.location.href.includes("post") || window.location.href.includes("blog")) {
    document.querySelector('#description').remove();
}
