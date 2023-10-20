$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    datatTable = $('#tblProductData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'name', "width": "25%" },
            /*{ data: 'description', "width": "15%" },*/
            { data: 'category.name', "width": "25%" },
            { data: 'listPrice', "width": "20%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2" >
                            <i class="bi bi-pencil-square"> Edit</i>
                                </a >
                        <a href="/admin/product/delete/${data}" class="btn btn-danger mx-2">
                            <i class="bi bi-trash-fill"> Delete</i>
                        </a>
                            </div >`
                },
                "width": "20%"
            },
        ]
    });
}

