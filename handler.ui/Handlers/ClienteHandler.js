var cliente = {

    init : function() {
        $('#cliCadastrar').on('click',
            function() {
                cliente.cadastrar();
            });
    },

    cadastrar : function() {
        var cli = {};
        cli.nome = "Elton Faustino";
        cli.idade = 23;

        $.post("http://localhost:62563/Ashx/ClienteHandler.ashx", cli , function(data) {

        });
    }

}
