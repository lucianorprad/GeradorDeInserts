GeradorDeInserts

🚀 Automatizando a geração de inserts para e-commerce
📌 Descrição

Este projeto foi desenvolvido para facilitar meu fluxo de trabalho como analista de suporte e eliminar a necessidade de tratar dados manualmente em planilhas.

No dia a dia, frequentemente preciso extrair produtos do banco de dados dos clientes para importá-los em suas plataformas de e-commerce, seguindo um formato específico exigido pelo sistema. Antes, esse processo envolvia manipulação manual de dados no Excel, o que era repetitivo e cansativo.

O GeradorDeInserts automatiza essa tarefa:
    Basta usar a função CONCAT(itens, ";") na consulta SQL, como já faria normalmente.
    Em seguida, exporte o resultado como CSV e jogue no aplicativo.
    O programa gera automaticamente os inserts no formato correto, pronto para importação.

🔧 Como Usar
    Execute sua consulta SQL com CONCAT(itens, ";").
    Exporte os dados em CSV.
    Carregue o arquivo no GeradorDeInserts.
    Copie e utilize os inserts gerados!

📂 Código-Fonte
A lógica principal do projeto está no arquivo Form1.cs.

🤝 Contribuições
Se quiser adaptar o projeto para suas necessidades, fique à vontade para fazer um fork e modificar conforme necessário. Sugestões e melhorias são sempre bem-vindas!
