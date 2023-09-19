function toLowerKeys(obj) {
    let newObj = {}
    for (const key in obj) {
        const newKey = key[0].toLowerCase() + key.slice(1);
        newObj = { ...newObj, [newKey]: obj[key] };
    }
    return newObj;
} 

function getAllProducts() {
    return new Promise(async (resolve, reject) => {
        try {
            const response = await axios.get('/Home/GetAll');
            if (response.status == 200) {
                const newData = response.data?.map(data => toLowerKeys(data));
                return resolve(newData);
            }
            throw new Error('Invalid Response Code: ' + response.status);
        } catch (error) {
            return reject(error.message);
        }
    });
}

function productDetailAlert (product) {
    const { name } = product;
    const template = (key, item) => `
    <li class='list-group-item'>
        ${ key }: ${ item }
    </li>`;
    
    let itemsHtml = '';
    for (const item in product)
        itemsHtml += template(item, product[item] instanceof Array ? product[item].join() : product[item]);

    Swal.fire({
        title: name ?? 'Details',
        html: `<ul class="list-group">${ itemsHtml }</ul>`
    })
}

function errorAlert (errorText) {
    Swal.fire({
        icon: 'error',
        title: 'Error',
        text: errorText
    })
}

function successAlert (successText) {
    Swal.fire({
        icon: 'success',
        title: 'Success',
        text: successText
    });
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
