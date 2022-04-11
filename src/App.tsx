import { FC } from 'react';
import { Layout } from './components/layout';

export const App: FC = () => {
  return (
    <div className="h-full flex flex-col">
      <Layout.Header />
      <main className="flex-1 container mx-auto">
      </main>
      <footer className="h-16 container mx-auto">
      </footer>
    </div>
  );
}
