# ttt
<div>
    <table>
        <br />
        <br />
        <br />
        <br />

        @*<div class="row">
            <div class="span4">*@
                
        <div class="btn-toolbar" role="toolbar">
            <div class="btn-group">
                <button type="button" class="btn default btn-lg">1</button>
                <button type="button" class="btn default btn-lg">2</button>
                <button type="button" class="btn default btn-lg">3</button>
            </div>
        </div>
        <div class="btn-toolbar" role="toolbar">
            <div class="btn-group">
                <button type="button" class="btn default btn-lg">4</button>
                <button type="button" class="btn default btn-lg">5</button>
                <button type="button" class="btn default btn-lg">6</button>
            </div>
        </div>
        <div class="btn-toolbar" role="toolbar">
            <div class="btn-group">
                <button type="button" class="btn default btn-lg">7</button>
                <button type="button" class="btn default btn-lg">8</button>
                <button type="button" class="btn default btn-lg">9</button>
            </div>
        </div>
            @*</div>
            <div class="span4">*@
            <h2>Чем хотите играть?</h2>
            <h2>Крестиками</h2><button type="button" class="btn default btn-lg">X</button>
            <h2>Ноликами</h2><button type="button" class="btn default btn-lg">O</button>
            @*</div>
            </div>*@
</table>
</div>


<div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                
                @*@Html.ActionLink("Имя приложения", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })*@
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <p class="navbar-text">Tic-Tac-Toe</p>
                    <li>@Html.ActionLink("Главная", "Index", "Home")</li> @*возможность вернуться на главную, с сохранением прогресса игры*@
                    <li>@Html.ActionLink("Новая игра", "New Game", "Home")</li>
                    <li>@Html.ActionLink("Статистика", "Statistic", "Home")</li>                   
                </ul>
            </div>
        </div>
