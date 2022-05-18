# CoverAll_API
## API Back-end do trabalho semestral da Uni9

A API esta escrita em C# .NET CORE 5, portanto é neccessário baixar a SDK e instalar a mesma através do link: https://dotnet.microsoft.com/en-us/download/dotnet/5.0.

Abra o console CMD do windows e verifique se o SDK foi nstalado corretamente com o comando 'dotnet --version'. 
Se instalado corretamente irá aparecer a versão atual intalada:
![image](https://user-images.githubusercontent.com/39097961/169160132-dc067278-bb2b-4aed-9e98-7a3953bf82b1.png)

Após a instalação entre na pasta raiz do projeto e verifique a existência do arquivo 'DataBase.db'.
Caso esteja presente quer dizer que o banco de dados esta criado.
Caso contrário precisa ser criado, execute o comando 'dotnet ef database update' para a criação do mesmo.
![image](https://user-images.githubusercontent.com/39097961/169160559-ff0b1f33-d52c-49a0-b579-5108941a78e5.png)

Após a criação do BD, a API esta pronta para ser executada, execute o comando 'dotnet run' e aguarde a inicialização.
![image](https://user-images.githubusercontent.com/39097961/169160723-cd118214-76ce-42bc-9a19-15b7705dfe29.png)

