import axios from "axios";

const Api = axios.create({
  baseURL: "https://localhost:5001/api/",
});

api.interceptors.request.use(async config => {
  const token = getToken();
  if (token) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});

export default Api ;