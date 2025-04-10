# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**Código-Base: Um único código-base rastreado em controle de versão.
Dependências: Declare e isole dependências explicitamente.
Configuração: Armazene configurações no ambiente, não no código.
Serviços de Apoio: Trate serviços externos como banco de dados, como recursos anexados.
Build, Release e Run: Separe as etapas de compilar, release e executar.
Processos Execute a aplicação como processos sem estado.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Apresentação, Negócio, aplicação e infraestrutura.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** Microserviços são independentes e agéis, enquanto SOA é uma arquitetira orientada a grande serviços
reutilizáveis.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** Gerenciamento e segurança no controle de APIs, como desevantagens talvez o custo e aumento na complexidade


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** a classe é usada para objetos e o struct para dados pequenos e fixos


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** A grande diferença entre as duas é que a .NET Core é multiplataforma, mais avançada e com mais
performance e com recursos de nuvem.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**GRPC é mais complexo e focado em desempenho enquanto REST usa formatos como JSON mais simples e verbos
como GET e POST baseado em HTTP 


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**Controla a navegação sem recarregar a página inteira, usando o histórico do browser e renderizando componentes
de forma dinâmica.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**É uma cultura de desenvolvimento junto a operações para acelerar entregas e melhorar a qualidade.


10. Explique sobre um método agile.

**Resposta:**SCRUM: Métodologia ágil com ciclos curtos focado em divisão de papéis, eventos e artefatos.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**CI/CD automatiza o processo de integração e entrega de código, permitindo testes e deploys rápidos 
e contínuos com ferramentas como GitHub Actions, GitLab CI, Jenkins e Azure DevOps.


12. Qual a diferença entre Docker e Containers.

**Resposta:** O Docker é uma ferramenta que permite a criação,manipulação e gerenciamento de Containers,
que é uma tecnologia para virtualização onde não é necessário um sistema operacional completo para rodar uma aplicação.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**Kubernetes é a plataforma open source para orquestração de containers, enquanto o OpenShift é uma solução da 
Red Hat baseada em Kubernetes, com recursos extras de segurança, interface web e ferramentas integradas para desenvolvedores.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**Vantagens: reutilização e escalabilidade. Desvantagens: Complexidade de gestão e latência. Preocupações:
Segurança e desempenho.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**Usando autenticação e logs.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Para comunicação entre diferentes sistemas ou serviços de forma assíncrona.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**Desconheço a estratégia.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**Prática de gerenciar infraestrutura e aplicações via Git como fonte única.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Logo que ingressei na área, um dos primeiros desafios foi criar um módulo para anexar arquivos, inicialmente
guias de exames relacionadas as solicitações x cadastros dos beneficiários do plano de saúde.
Obstáculos eram a limitação de uma linguagem antiga e limitada (Centura) e espaço. Visto que era um sistema com
mais de 20 anos sem a função de anexo de arquivos inicialmente criei primeiro conceito de como funcionaria
contornando as funcionalidades da linguagem. Foi criada uma tabela no Oracle para controlar os registros e evitar
duplicidade de arquivos. A forma como ele funcionou inicialmente foi utilizando um espaço de uma pasta compartilhada
o arquivo era vinculado ao cadastro no registro do SQL, gerada uma cópia do arquivo a fim de poder manipular o mesmo
e move-lo para a pasta compartilhada. Assim o mesmo ficava livre para ser excluído dos temporários caso necessário 
e a cópia anexada estava segura no servidor. Após uma alteração na rede devido a venda da empresa e inserção de novos
recursos, a pasta foi alterada para sharepoint na nuvem, onde possui maior escalabilidade e a Configuração
é automática para cada usuário via um arquivo que trás as propriedades do caminho da pasta.
O Módulo devido ao sucesso foi depois replicado com suas devidas alterações em outros setores para outras funcionalidades.

