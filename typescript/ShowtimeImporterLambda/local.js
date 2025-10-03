const indexModule = require("./dist");

const cliArg = process.argv[2];
const json = JSON.parse(cliArg);
(async () => {
  console.log("Input:", json);
  const response = await indexModule.handler(json);
  console.log("Response:", response);
})();

