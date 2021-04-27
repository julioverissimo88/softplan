# Softplan

Para rodar o projeto � necess�rio possuir dotnetcore 3.1, dotnetcore cli

#### 1 - Clonar reposit�rio
`https://github.com/julioverissimo88/softplan.git`

#### 2 - Restaurar pacotes
```  
> cd api/
> dotnet restore
```

```  
> cd api-calculo/
> dotnet restore
```
## OU

Pelo visual studio restaurar pacotes nuget em ambos projetos
****

#### 3 - Run!!
```  
> cd api/
> dotnet run
```

A api que devolve o calcula estar� escutando na porta 5001 ( https://localhost:5001 )

`Obs: Caso sua m�quina esteja com essa porta ocupada ser� necess�rio alterar no arquivo de config.`

## OU 

`De o Play via Visual Studio`

**Documenta��o Swagger**

https://localhost:5001/swagger/index.html `*(A porta da Url pode variar de acordo com a disponibilidade de portas de sua maquina)`

![](https://pasteboard.co/JZieGVc.png)

**Pacotes utilizados**
- Swagger (Documenta��o da API)