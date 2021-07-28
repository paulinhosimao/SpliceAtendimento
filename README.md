# SpliceAtendimento
API de Atendimento
### Backend Test

Esta é uma avaliação básica de código.

O objetivo é conhecer um pouco do seu conhecimento/prática de RESTful, C#.

Recomendamos que você não gaste mais do que 4 - 6 horas.

Entregar o teste em um repositorio do github público.

### Tarefas

Com a seguinte representação de um atendimento:

```json
{
  "codigo": "1",
  "dataInicio": "2021-07-15T12:33:00.511Z",
  "dataFim": "2021-07-15T12:33:00.511Z",
  "veiculo": "ABC1234",
  "operador": "Operador Teste",
  "finalizado": true,
  "quantidadeAcoes": 1,
  "acoes": [
    {
      "nome": "teste",
      "valor": "123"
    }
  ]
}
```

Crie endpoints para as seguintes ações:

- [ ] Criação de um atendimento onde o payload será o json informado acima (exceto a propriedades **quantidadeAcoes** e **finalizado**)

- [ ] Edição de atendimento pelo **codigo**

- [ ] Recuperação de atendimento por **codigo**

- [ ] Deleção de atendimento por **codigo**

### Requisitos

- [ ] Toda vez que um atendimento for recuperado por **codigo** deverá ser calculado a propriedade: **quantidadeAcoes**

        A propriedade quantidadeAcoes é a soma das acoes

- [ ] Toda vez que um atendimento for recuperado por **codigo** deverá ser verificado a propriedade: **finalizado**

        Um atendimento é finalizado quando o campo dataFim não for null

- [ ] Caso um atendimento já existente em memória tente ser criado com o mesmo **codigo** uma exceção deverá ser lançada

        Dois atendimentos são considerados iguais se os seus codigos forem iguais

- [ ] Ao atualizar um atendimento, o antigo deve ser sobrescrito com o que esta sendo enviado na requisição

        A requisição deve receber o codigo e atualizar com o atendimento que tbm esta vindo na requisição

### Dicas

- Os atendimentos podem ficar em memória, não é necessário persistir os dados
