import { FC } from "react";
import { Route, Routes } from "react-router-dom";
import { Layout } from "./components/layout";
import { GoodsView } from "./components/views/goods";
import { ProductView } from "./components/views/product";
import { SignView } from "./components/views/sign";

export const App: FC = () => {
  return (
    <div className="h-full flex flex-col">
      <Layout.Header />
      <main className="container-by-default flex-1">
        <Routes>
          <Route path="/goods" element={<GoodsView />} />
          <Route path="/product/:id" element={<ProductView />} />
          <Route path="/sign" element={<SignView />} />
        </Routes>
      </main>
      <footer className="container-by-default h-16">
      </footer>
    </div>
  );
}
