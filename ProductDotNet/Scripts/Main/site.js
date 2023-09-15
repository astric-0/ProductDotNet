function gethost(path = '/') {
    return "https://localhost:44326" + path;
}

function errorAlert (errorText) {
    Swal.fire({
        icon: 'error',
        title: 'Error',
        text: errorText
    })
}

function errorsAlert(errors) {
    const template = error => `<li class='list-group-item list-group-item-danger'> ${ error } </li>`;

    let htmlStr = '';
    Object.keys(errors).forEach(error => (htmlStr += template(errors[error])));

    Swal.fire({
        icon: 'error',
        title: 'Error',
        html: `
            <ul>
                ${ htmlStr }
            </ul>
        `
    });
}

const app = Vue.createApp(appProps ?? {});

(_ => {
    const componentList = [
        { name: 'c-input', main: inputCP }
    ];

    const setComponent = component => {
        const { name, main } = component;
        if (!(name && main)) return;
        app.component(name, main);
    }

    componentList.forEach(component => setComponent(component));
})();

app.mount("#app");