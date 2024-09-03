Teste função sistemas

#Observações 1 - Foi sugerido no teste que na tela de inclusão fosse colocado manutenção nos beneficiarios (inclusao, alteração e exclusão) no pop-up, porém nesse contexto não temos o IDcliente para vincular, entendo que por ser um teste de aptidão para demonstrar capacidade tomei a liberdade de colocar um hardcoded IdCliente=1

2 - Foi criado uma constraint nos campos CPF das tabelas Clientes e Beneficiarios para garantir a unicidade e integridade dos dados, alem do codigo de verificação.

3 - Se der erros de sql-server networking ou correlatos, ao baixar o projeto acesse as propriedades do banco (arquivos mdf e ldf da pasta app-data) e dê um unblock em ambos, não sei porque mas o git fez isso, deve ser por causa do versionamento.
