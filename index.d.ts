declare module '@apiverve/stockmarketopentimes' {
  export interface stockmarketopentimesOptions {
    api_key: string;
    secure?: boolean;
  }

  export interface stockmarketopentimesResponse {
    status: string;
    error: string | null;
    data: any;
    code?: number;
  }

  export default class stockmarketopentimesWrapper {
    constructor(options: stockmarketopentimesOptions);

    execute(callback: (error: any, data: stockmarketopentimesResponse | null) => void): Promise<stockmarketopentimesResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: stockmarketopentimesResponse | null) => void): Promise<stockmarketopentimesResponse>;
    execute(query?: Record<string, any>): Promise<stockmarketopentimesResponse>;
  }
}
