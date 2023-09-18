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
   
    const check = cb => {
        try {
            return cb();
        } catch (_) {
            return false;
        }
    }

    const componentList = [
        { name: 'c-input', main: check(_ => inputCP) },
        { name: 'c-checkboxes', main: check(_ => checkBoxCP) },
        { name: 'c-radiobtns', main: check(_ => radioCP) }
    ];

    const nonloaded = [];
    const setComponent = component => {
        const { name, main } = component;
        if (!(name && main)) {
            nonloaded.push(name ?? main ?? 'component')
            return;
        };
        app.component(name, main);
    }
    componentList.forEach(component => setComponent(component));
    nonloaded.length > 0 && console.log("Nonloaded Components: ", nonloaded);
})();

app.mount("#app");