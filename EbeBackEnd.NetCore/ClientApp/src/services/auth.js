export const TOKEN_KEY = "@EvenBetterEvents";

export const isAuthenticated = () => localStorage.getItem(TOKEN_KEY) !== null;

export const getToken = () => localStorage.getItem(TOKEN_KEY);

export const login = token => {
  localStorage.setItem(TOKEN_KEY, token);
  console.log(token);
};

export const logout = () => {
  localStorage.removeItem(TOKEN_KEY);
};
