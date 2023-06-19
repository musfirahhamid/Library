function openSidebar() {
    document.querySelector('.sidebar').style.left = '0';
    document.querySelector('.content').style.marginLeft = '250px';
}

function closeSidebar() {
    document.querySelector('.sidebar').style.left = '-250px';
    document.querySelector('.content').style.marginLeft = '0';
}

function toggleTheme() {
    const body = document.querySelector('body');
    body.classList.toggle('dark-mode');
    body.classList.toggle('light-mode');
   
}


