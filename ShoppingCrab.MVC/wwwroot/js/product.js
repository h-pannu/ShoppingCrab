var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    debugger;
    dataTable = $('#tblProductData').DataTable({
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
                        <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2">
                            <i class="bi bi-trash-fill"> Delete</i>
                        </a>
                            </div >`
                },
                "width": "30%"
            },
        ]
    });
}

function Delete(url) {
    debugger;
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    debugger;
                    dataTable.ajax.reload();
                    toast.success(data.message)
                }
                })
        }
    })
}

