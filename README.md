# Softplan

Para rodar o projeto é necessário possuir dotnetcore 3.1, dotnetcore cli

#### 1 - Clonar repositório
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

A api que devolve o calcula estará escutando na porta 5001 ( https://localhost:5001 )

`Obs: Caso sua máquina esteja com essa porta ocupada será necessário alterar no arquivo de config.`

## OU 

`De o Play via Visual Studio`

**Documentação Swagger**

https://localhost:5001/swagger/index.html `*(A porta da Url pode variar de acordo com a disponibilidade de portas de sua maquina)`

![](https://pasteboard.co/JZieGVc.png)

**Pacotes utilizados**
- Swagger (Documentação da API)