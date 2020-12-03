# Configurando Frontend (Angular)
Após clonar todo o projeto, e verificar os requisitos do sistema, para que rode perfeitamente, configure o frontend da seguinte forma:
1.	Abra o terminal na pasta raiz do projeto front_meet_room, e com o Node e Angular CLI devidamente instalado, execute o comando para instalar todas as dependências do projeto:
npm install
2.	Com tudo devidamente instalado, apenas execute o comando para rodar o projeto:
npm start ou ng serve
O projeto irá rodar no endereço padrão: localhost:4200. Acesse nesse endereço, e utilize o projeto. No caminho src/app/service, está configurada o endereço local onde sua API, que já deve estar rodando. Caso precise mudar, poderá fazê-lo modificando o valor inputado na variável "baseUrl". Com isso, tudo pronto para o frontend se "comunicar" com o backend, e retornar os dados necessários.

