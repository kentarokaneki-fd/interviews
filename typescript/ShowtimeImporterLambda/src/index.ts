import { LambdaParameters } from "./interfaces/LambdaParameters";
import { LambdaResponse } from "./interfaces/LambdaResponse";

export const handler = async (
  params: LambdaParameters
): Promise<LambdaResponse> => {
  return {
    Result: params.Text.toUpperCase(),
  };
};
