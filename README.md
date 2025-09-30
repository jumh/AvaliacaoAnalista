# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** Não conhecia esses Fatores

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Infraestrutura, Business, Aplicação de Apresentação


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** Sei que SOA usa o XML, não trabalhei com isso, mas microserviços sim, criando serviços pequenos e com responsabilidades únicas.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** É uma forma de centralizar o controle, fazer a gestão e monitoramento de como as APIs serão utilizadas. 
A vantagem é que fica padronizado, mais seguro, sem falar que dá pra fazer o monitoramento e ver as métricas.
Desvantagem, talves o custo da solução, ou o trabalho de ter mais uma camada. Mas vejo como mais vantagem, do que desvantagem na maioria dos projetos.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** De forma bem direta, o Struct é mais leve pra memória, e imutável, já a Classe possui mais recursos, tanto pra herdar quanto a opção de poder mexer no construtor.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** .Net é o mais antigo, que funcionava só no Windows, mais lento.
Já o .Net Core funciona no Windows, Linux, MacOs, dá pra usar o servidor Kestrel, e também ficou mais leve, rápido, muito melhor pra microserviços e aplicações web.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** Eu não sei sobre o GRPC ainda, mas o REST, se for o da comunicação que as APIs usam é o seguinte:
É usado o formato JSON na comunicação, e REST é o padrão para os métodos de Delete, Get, Post e Put.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** Não sei os nomes para isso agora, mas sei que o processamento da requisição acontece no próprio dispositivo do cliente, sem precisar ficar recarregando página.
No Angular já usei para que cada rota pudesse puxar seu próprio componente conforme a navegação acontecia.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** Usei e uso os recursos do Azure para isso, pra garantir mais qualidade e velocidade de entrega.
Pois quando a gente automatiza, os desenvolvedores focam mais no código. É melhor também pra fazer o monitoramento e ter o controle das entregas.


10. Explique sobre um método agile.

**Resposta:** Confio bastante neste modelo, pois realmente faz diferença pro time, as Dailys, Reviews, Retrospectiva e Planning, vejo o melhor momento para discutir as entregas de valor.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI onde se tem um repositório compartilhado com todo o time, e dá pra colocar a execução de um pipeline automático pra fazer o build e testes.
CD, onde tem o despejo ou melhor, a entrega da aplicação no ambiente, seja homol ou produção.
No caso, se usar o Azure, tem a ferramenta de Azure DevOps.


12. Qual a diferença entre Docker e Containers.

**Resposta:** Docker é um recurso que podemos usar para criar imagens de aplicações, e dá pra usar o Docker Hub para compartilhar estas imagens, dá também para gerenciar containers.
Já o container, podemos imaginar de fato um container, só que necessários para aplicação, onde possui todos os recursos exclusivos para execução, como código, bibliotecas e configuração.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Openshift não conheço ainda, mas Kubernetes serve para gerenciar os containers. Usei bastante os arquivos K8s, pra deixar configurado escalabilidade, réplicas, balanceamento e ter segurança.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**  Quando se usa o recurso de versão, acho interessante, pra manter o uso antigo ainda eficiente, a facilidade de manutenção é melhor. 
Não precisa ficar de fato dependente, fica melhor pra escalar e resuar, ajuda muito quando o uso é para integrações.
A maior preocupação vem na autenticação, a segurança precisa estar atualizada sempre, junto com uma boa documentação.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Com uma boa elaboração de Autenticação, Autorização, também o uso de Monitoramento e Log, e configurar o CORS de acordo com o uso, e testes.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Pra modelar corretamente o uso, por exemplo, se usar o RabbitMQ ou Kafka, pode-se enviar mensagens e os sistemas envolvidos não precisam ficar acoplados.
Este processo de ser assíncrono, que vai sendo executado em segundo plano, funciona muito bem em sistemas complexos, com fluxo de trabalho pesado.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** SAGA não conheço ainda, não sei como funciona em microservice.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** Não sei ainda sobre GitOps.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Maravilha, a mais recente foi na alteração de uma boletagem de Títulos Privados Ativos.
As Tecnologias utilizadas envolviam o uso do .Net Core com C# e o Razor, porém muitas funcionalidades específicas de tela estão em agrangência JavaScript.
Corrigi uma dívida técnica que o time possuía, criei uma nova estrutura atendendo melhor os conceitos SOLID.
Migrei os dados antigos nas novas tabelas, mantive as funcionalidades originais, e melhorei o recurso que fazia um boleto por vez, para que agora suporte 100 boletos processados de forma automatizada.
