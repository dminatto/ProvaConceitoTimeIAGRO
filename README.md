
# Catálogo de livros


## Requisitos

Um cliente tem necessidade de buscar livros em um catálogo. Esse cliente quer ler e buscar esse catálogo de um arquivo JSON, e esse arquivo não pode ser modificado. Então com essa informação, é preciso desenvolver:

- Criar uma API para buscar produtos no arquivo JSON disponibilizado.
- Que seja possível buscar livros por suas especificações(autor, nome do livro ou outro atributo)
- É preciso que o resultado possa ser ordenado pelo preço.(asc e desc)
- Disponibilizar um método que calcule o valor do frete em 20% o valor do livro.

Será avaliado no desafio:

- Organização de código;
- Manutenibilidade;
- Princípios de orientação à objetos;
- Padrões de projeto;
- Teste unitário

Para nos enviar o código, crie um fork desse repositório e quando finalizar, mande um pull-request para nós.

O projeto deve ser desenvolvido em C#, utilizando o .NET Core 3.1 ou superior.

Gostaríamos que fosse evitado a utilização de frameworks, e que tivesse uma explicação do que é necessário para funcionar o projeto e os testes.

## Solução

Para ler e buscar dados em um arquivo JSON, usei o proprio bind da ` System.Text.Json`, adicionei nas models a marcação ` JsonPropertyNameAttribute` nas chaves que tinham espaço e inclui a configuração `PropertyNameCaseInsensitive` para ignorar diferença entre letras maiúsculas e minúsculas. 

Para a pesquisa usei LINQ, e para a montagem dos filtros criei um helper `BookParameters` onde modelei os possíveis filtros. Na função `Find` faço o bind dos parâmetros e os mando para o repository. Lá chamo outro helper `BookFilter` onde monto os filtros para a query de acordo com os parâmetros informados 

### Endpoints

<details>
  <summary> 
  `/books`
  </summary><br />

Pode ser chamado sozinho ou acompanhado por uma query string ex: `?illustrator=Cliff Wright&genre=Drama` 

O filtro retorna exatamente o que está sendo buscado  

</details>

 
<details>
  <summary> 
  `/books/:id/shipping` 
  </summary><br />

Retorna o valor do frete para o ID do livro procurado 
</details>

# Orientações

  ## Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.

  ### Executando a api

  Para executar a apo com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` 

  ```
  dotnet run
  ```

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.
